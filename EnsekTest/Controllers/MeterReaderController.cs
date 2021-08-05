using EnsekTest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace EnsekTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterReaderController : ControllerBase
    {
        private readonly IMeterService _meterService; 
        private readonly ILogger<MeterReaderController> _logger;
        public MeterReaderController(IMeterService meterService, ILogger<MeterReaderController> logger)
        {
            _meterService = meterService;
            _logger = logger;

        }

        [HttpGet("GetAllAccounts")]
        public IActionResult GetAllAccounts()
        {
            try
            {
                return Ok(_meterService.GetAllAccounts());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllAccounts action: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }
        }


        [HttpGet("GetAccount/{id}")]
        public IActionResult GetAccount(int id)
        {
            try
            {
                return Ok(_meterService.GetAccount(id));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAccount action: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("GetAllReadings")]
        public IActionResult GetAllReadings()
        {
            try
            {
                return Ok(_meterService.GetAllReadings());
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllReadings action: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }
        }


        [HttpGet("GetReading/{id}")]
        public IActionResult GetReading(int id)
        {
            try
            {
                return Ok(_meterService.GetReading(id));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetReading action: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost("ProcessMeterReadingCSV")]
        public IActionResult ProcessMeterReadingCSV(IFormFile file)
        {
            try
            {
                return Ok(_meterService.ProcessReadings(file));
            }

            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside ProcessMeterReadingCSV action: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }

        }

    }
}
