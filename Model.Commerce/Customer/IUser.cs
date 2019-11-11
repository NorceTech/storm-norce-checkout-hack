﻿using System;
using System.Collections.Generic;
using System.Text;
/******************************************************************************
 ** Author: Fredrik Gustavsson, Jolix AB, www.jolix.se
 ** Purpose: Sample code for how to build an integration from a frontend
 **          solution to communicate with Storm Commerce (storm.io)
 ** Copyright (C) Jolix AB, Storm Commerce AB
 ******************************************************************************/
namespace Model.Commerce.Customer
{
    public interface IUser
    {
        string ExternalId { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        ICompany Company { get; set; }
        string CurrencyCode { get; set; }
        string LanguageCode { get; set; }
    }
}
