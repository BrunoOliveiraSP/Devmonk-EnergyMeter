using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;


namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnergyMeterController : ControllerBase
    {
        
        [HttpGet]
        public Models.ClienteInfo[] GetEnergyData() 
        {
            return new List<Models.ClienteInfo>
            {
                new Models.ClienteInfo() 
                { 
                    ClientCode = 43523, 
                    ZipCode = "04613-843", 
                    AddressNumber = "4654",
                    Complement = string.Empty,
                    EnergyData = new List<Models.EnergyData>()
                    {
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "A324AF34",
                            MeasureDate = new DateTime(2021, 3, 12),
                            Device = 4,
                            KiloWatss = 81
                        },
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "A324AF34",
                            MeasureDate = new DateTime(2021, 3, 11),
                            Device = 5,
                            KiloWatss = 12
                        },
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "A324AF34",
                            MeasureDate = new DateTime(2021, 3, 10),
                            Device = 7,
                            KiloWatss = 45
                        },
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "A324AF34",
                            MeasureDate = new DateTime(2021, 3, 9),
                            Device = 4,
                            KiloWatss = 81
                        }
                    }.ToArray()
                },
                new Models.ClienteInfo() 
                { 
                    ClientCode = 8465, 
                    ZipCode = "24468-985", 
                    AddressNumber = "1012A",
                    Complement = "122A",
                    EnergyData = new List<Models.EnergyData>()
                    {
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "B8344001",
                            MeasureDate = new DateTime(2021, 3, 3),
                            Device = 9,
                            KiloWatss = 125
                        },
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "B8344001",
                            MeasureDate = new DateTime(2021, 3, 10),
                            Device = 3,
                            KiloWatss = 69
                        },
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "B8344001",
                            MeasureDate = new DateTime(2021, 3, 4),
                            Device = 2,
                            KiloWatss = 42
                        },
                        new Models.EnergyData()
                        {
                            EnergyMeterCode = "B8344001",
                            MeasureDate = new DateTime(2021, 3, 8),
                            Device = 1,
                            KiloWatss = 77
                        }
                    }.ToArray()
                }
            }.ToArray();
        }

    }
}
