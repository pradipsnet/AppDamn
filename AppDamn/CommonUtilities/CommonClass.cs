using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Text;

namespace AppDamn.CommonUtilities
{
    
        public static class UIFieldFormat
        {
            public static Object NullToText(Object value)
            {
                try
                {
                    if (value == null)
                        return "";

                    if (value is string)
                        return ((string)value).Trim();

                    return value.ToString();
                }
                catch
                {
                    return value;
                }
            }

            public static string ReplaceJunkCharsWithEmpty(string value)
            {
                try
                {
                    if (value == null)
                        return "";

                    if (value is string)
                        return value.Trim().Replace("\0", string.Empty);

                    return value.ToString();
                }
                catch
                {
                    return value;
                }
            }

            public static Object NullToDecimal(Object value)
            {
                try
                {
                    if (value == null)
                        return 0;

                    if (value is string)
                        return ((string)value).Trim();

                    return Convert.ToDecimal(value);
                }
                catch
                {
                    return value;
                }
            }

            public static string FormatDate(string date, bool yearfirst)
            {
                try
                {
                    if (date != null && date.Trim() != "" && date.Trim() != "00000000")
                    {
                        if (date.IndexOf("/") == -1)
                        {
                            string dd, mm, yy;
                            if (yearfirst)
                            {
                                yy = date.Substring(0, 4);
                                mm = date.Substring(4, 2);
                                dd = date.Substring(6, 2);
                            }
                            else
                            {
                                mm = date.Substring(0, 2);
                                dd = date.Substring(2, 2);
                                yy = date.Substring(4, 4);
                            }
                            date = mm + "/" + dd + "/" + yy;
                        }
                    }
                    else
                    {
                        date = "";
                    }
                    return date;
                }
                catch
                {
                    return date;
                }
            }

            public static string FormatTime(string time)
            {
                try
                {
                    if (time != null && time.Trim() != "")
                    {

                        if (time.IndexOf(":") == -1)
                        {
                            string hh, mm, ss, shift;
                            hh = time.Substring(0, 2);
                            mm = time.Substring(2, 2);
                            ss = time.Substring(4, 2);

                            int temphh = Int16.Parse(hh);
                            if (temphh >= 12 && temphh < 24)
                            {
                                shift = "PM";
                            }
                            else
                            {
                                shift = "AM";
                            }

                            if (temphh == 24)
                            {
                                hh = Convert.ToString(00);
                            }
                            else if (temphh > 12)
                            {
                                hh = Convert.ToString(temphh - 12);
                                if (hh.Length == 1)
                                    hh = "0" + hh;
                            }
                            time = hh + ":" + mm + ":" + ss + " " + shift;
                        }
                    }
                    return time;
                }
                catch
                {
                    return time;
                }
            }

            public static string FormatDate(string date)
            {
                return FormatDate(date, false);
            }

            public static string RemoveSpecialChar(string str)
            {
                StringBuilder sb = new StringBuilder();
                try
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        foreach (char c in str)
                        {
                            //if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                            if ((c >= '0' && c <= '9'))
                            {
                                sb.Append(c);
                            }
                        }
                    }
                    return sb.ToString();
                }
                catch
                {
                    return str;
                }

            }
            /// <summary>
            /// Method is used to Format Date in yyyyddMM 
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string ChangeDateFormat(string str)
            {
                try
                {
                    string datToStr = "";

                    if (!string.IsNullOrEmpty(str))
                    {
                        DateTime result;
                        bool res = DateTime.TryParseExact(str, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out result);
                        if (res)
                        {
                            datToStr = result.ToString("yyyyMMdd");
                        }
                        else { datToStr = result.ToString("00000000"); }

                    }
                    return datToStr;
                }
                catch
                {

                    return str;
                }

            }
            /// <summary>
            /// Method is used to Format Date in MMddyyyy 
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string DateFormatYearLast(string str)
            {
                try
                {
                    string datToStr = "";

                    if (!string.IsNullOrEmpty(str))
                    {
                        DateTime result;
                        bool res = DateTime.TryParseExact(str, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out result);
                        if (res)
                        {
                            datToStr = result.ToString("MMddyyyy");
                        }
                        else { datToStr = result.ToString("00000000"); }

                    }
                    return datToStr;
                }
                catch
                {

                    return str;
                }

            }

            public static string DateFormatMMDDYY(string str)
            {
                try
                {
                    string datToStr = "";
                    if (!string.IsNullOrEmpty(str))
                    {
                        DateTime result;
                        bool res = DateTime.TryParseExact(str, "MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None, out result);
                        if (res)
                        {
                            datToStr = result.ToString("MMddyy");
                        }
                        else { datToStr = result.ToString("000000"); }
                    }
                    return datToStr;
                }
                catch
                {

                    return str;
                }
            }

            /// <summary>
            /// Method is used to Format Date in MMddyyyy 
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string DateFormatAddSlash(string str)
            {
                try
                {
                    string datToStr = "";
                    DateTime result;
                    bool res = DateTime.TryParseExact(str, "MMddyyyy", new CultureInfo("en-US"), DateTimeStyles.None, out result);
                    if ((res) && (result.Year >= 2000))
                    {
                        datToStr = result.ToString("MM/dd/yyyy");
                    }
                    else if ((res != true) || (result.Year <= 2000)) { datToStr = DateTime.Now.ToString("MM/dd/yyyy"); }

                    return datToStr;
                }
                catch (Exception ex)
                {
                    return str;
                }

            }
            /// <summary>
            /// Method is used to Format Date in MM/dd/yyyy if year first
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string DateFormatyyyyMMddAddSlash(string str)
            {
                try
                {
                    string datToStr = "";
                    DateTime result;

                    bool res = DateTime.TryParseExact(str, "yyyyMMdd", new CultureInfo("en-US"), DateTimeStyles.None, out result);
                    if (res)
                    {
                        datToStr = result.ToString("MM/dd/yyyy");
                    }
                    return datToStr;
                }
                catch (Exception ex)
                {

                    return str;
                }

            }
            /// <summary>
            /// Method is used to Format Date in From MMddyyyy TO MM/dd/yyyy if year first
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string DateFormatMMddyyyyAddSlash(string str)
            {
                try
                {
                    string datToStr = "";
                    DateTime result;

                    bool res = DateTime.TryParseExact(str, "MMddyyyy", new CultureInfo("en-US"), DateTimeStyles.None, out result);
                    if (res)
                    {
                        datToStr = result.ToString("MM/dd/yyyy");
                    }


                    return datToStr;
                }
                catch (Exception ex)
                {

                    return str;
                }

            }

            public static string FormatFaxSheetServiceDate(string date)
            {
                try
                {
                    if (date != null && date.Trim() != "")
                    {
                        if (date.IndexOf("/") == -1)
                        {
                            string dd, mm, yy;
                            yy = date.Substring(2, 2);
                            mm = date.Substring(4, 2);
                            dd = date.Substring(6, 2);
                            date = mm + "/" + dd + "/" + yy;
                        }
                    }
                    else
                    {
                        date = "00/00/00";
                    }
                    return date;
                }
                catch
                {
                    return date;
                }
            }

            /// <summary>
            /// Method is used to Format Date in From MMddyyyy TO MM/dd/yyyy, return 00/00/0000 if date blank or invalid
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
            public static string DateFormatServiceDates(string str)
            {
                try
                {
                    string datToStr = "";
                    DateTime result;
                    if (str.IndexOf("/") == -1)
                    {
                        bool res = DateTime.TryParseExact(str, "yyyyMMdd", new CultureInfo("en-US"), DateTimeStyles.None, out result);
                        if (res)
                        { datToStr = result.ToString("MM/dd/yyyy"); }
                        else { datToStr = "00/00/0000"; }
                    }
                    else { datToStr = str; }
                    return datToStr;
                }
                catch (Exception ex)
                {
                    return str;
                }

            }

            /// <summary>
            /// This method is used to check ICD Version according to service date
            /// </summary>
            /// <param name="firstdate"></param>
            /// <param name="seconddate"></param>
            /// <returns>0,1,-1,-100</returns>
            public static int CompareDates(string firstdate, string seconddate)
            {
                try
                {
                    DateTime firstDateOut;
                    DateTime secondDateOut;
                    int result = -100;
                    bool serviceDate = DateTime.TryParse(firstdate, out firstDateOut);
                    bool icdEffDate = DateTime.TryParse(seconddate, out secondDateOut);
                    if (serviceDate && icdEffDate) { result = DateTime.Compare(firstDateOut, secondDateOut); }
                    return result;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
