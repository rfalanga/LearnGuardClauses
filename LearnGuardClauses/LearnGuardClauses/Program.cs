﻿using LearnGuardClauses;

var o = new Order("Some Order", 1, 10, (decimal)0.25, DateTime.Now);
Console.WriteLine(o.ToString());