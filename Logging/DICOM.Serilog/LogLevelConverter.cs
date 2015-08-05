﻿// Copyright (c) 2012-2015 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using Serilog.Events;

namespace Dicom.Log
{
    internal static class LogLevelConverter
    {
        public static LogEventLevel ToSerilog(this LogLevel dicomLogLevel)
        {
            switch (dicomLogLevel)
            {
                case LogLevel.Debug:
                    return LogEventLevel.Debug;
                case LogLevel.Info:
                    return LogEventLevel.Information;
                case LogLevel.Warning:
                    return LogEventLevel.Warning;
                case LogLevel.Error:
                    return LogEventLevel.Error;
                case LogLevel.Fatal:
                    return LogEventLevel.Fatal;
                default:
                    //pathological case - shouldn't occur
                    return LogEventLevel.Verbose;
            }

        }
    }
}
