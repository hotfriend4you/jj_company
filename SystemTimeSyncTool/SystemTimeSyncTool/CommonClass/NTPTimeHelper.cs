﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace SystemTimeSyncTool.CommonClass
{
    class NTPTimeHelper
    {
        private struct Systemtime
        {
            public short year;
            public short month;
            public short dayOfWeek;
            public short day;
            public short hour;
            public short minute;
            public short second;
            public short milliseconds;
        }

        [DllImport("kernel32.dll")]
        private static extern bool SetLocalTime(ref Systemtime time);

        private static uint swapEndian(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
            ((x & 0x0000ff00) << 8) +
            ((x & 0x00ff0000) >> 8) +
            ((x & 0xff000000) >> 24));
        }

        /// <summary>
        /// 设置系统时间
        /// </summary>
        /// <param name="dt">需要设置的时间</param>
        /// <returns>返回系统时间设置状态，true为成功，false为失败</returns>
        public static bool UseDllSetLocalDateTime(DateTime dt)
        {
            Systemtime st;
            st.year = (short)dt.Year;
            st.month = (short)dt.Month;
            st.dayOfWeek = (short)dt.DayOfWeek;
            st.day = (short)dt.Day;
            st.hour = (short)dt.Hour;
            st.minute = (short)dt.Minute;
            st.second = (short)dt.Second;
            st.milliseconds = (short)dt.Millisecond;
            bool rt = SetLocalTime(ref st);
            return rt;
        }
        private static IPAddress iPAddress = null;

        /// <summary>
        /// 获取NTP服务器时间，若返回值是1900年1月1日,或者出错信息不是空，则获取失败
        /// </summary>
        /// <param name="host">传入NTP服务器</param>
        /// <param name="ErrorMessage">出错信息</param>
        /// <returns>返回获取的时间</returns>
        public static DateTime GetNtpDateTime(string host, out string ErrorMessage)
        {
            DateTime WebDateTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            try
            {
                ErrorMessage = "";
                if (String.IsNullOrEmpty(host))
                {
                    ErrorMessage = "Ntp Host is empty";
                    return WebDateTime;
                }

                var iphostinfo = Dns.GetHostEntry(host);
                var ntpServer = iphostinfo.AddressList[0];
                iPAddress = ntpServer;

                //NTP消息大小摘要是16字节 (RFC 2030)
                byte[] ntpData = new byte[48];
                //设置跳跃指示器、版本号和模式值
                ntpData[0] = 0x1B; // LI = 0 (no warning), VN = 3 (IPv4 only), Mode = 3 (Client Mode)
                IPAddress ip = iPAddress;
                // NTP服务给UDP分配的端口号是123
                IPEndPoint ipEndPoint = new IPEndPoint(ip, 123);
                // 使用UTP进行通讯
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                DateTime dtStart = DateTime.Now;
                socket.Connect(ipEndPoint);
                socket.ReceiveTimeout = 500;
                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket?.Close();
                socket?.Dispose();
                DateTime dtEnd = DateTime.Now;
                //传输时间戳字段偏移量，以64位时间戳格式，应答离开客户端服务器的时间
                const byte serverReplyTime = 40;
                // 获得秒的部分
                ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);
                //获取秒的部分
                ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);
                //由big-endian 到 little-endian的转换
                intPart = swapEndian(intPart);
                fractPart = swapEndian(fractPart);
                ulong milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000UL);
                // UTC时间
                WebDateTime = WebDateTime.AddMilliseconds(milliseconds);
                //webTime = webTime.Subtract(-(dtEnd - dtStart));
                //本地时间
                WebDateTime = WebDateTime.ToLocalTime();
                return WebDateTime;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return WebDateTime;
            }
        }

    }
}