﻿namespace Logistics.Models;

public class TruckDriversDto
{
    public TruckDto? Truck { get; set; }
    public IEnumerable<EmployeeDto>? Drivers { get; set; }
}
