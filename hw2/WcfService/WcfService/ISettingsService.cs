﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    public interface ISettingsService
    {
        string FileName { get; set; }
    }
}
