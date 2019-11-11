﻿using System;
using System.Collections.Generic;
using System.Text;
/******************************************************************************
 ** Author: Fredrik Gustavsson, Jolix AB, www.jolix.se
 ** Purpose: Sample code for how to build an integration from a frontend
 **          solution to communicate with Storm Commerce (storm.io)
 ** Copyright (C) Jolix AB, Storm Commerce AB
 ******************************************************************************/
namespace Model.Commerce.Product
{
    public interface ICategory
    {
        string ExternalId { get; set; }
        string ParentId { get; set; }
        int Level { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        List<ICategory> Children { get; set; }
    }
}
