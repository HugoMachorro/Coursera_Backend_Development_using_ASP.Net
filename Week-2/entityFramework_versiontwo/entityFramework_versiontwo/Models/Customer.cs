﻿using System;
using System.Collections.Generic;

namespace entityFramework_versiontwo.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public double? CustomerAmount { get; set; }

    public string? City { get; set; }
}
