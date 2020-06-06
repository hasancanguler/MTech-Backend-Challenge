using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MTechBuss.BankAPI;

namespace BankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyTransferController : ControllerBase
    {
        MoneyTransfer moneyTransfer = new MoneyTransfer();

        [HttpPost]
        public IActionResult Start([FromBody] List<MoneyTransaction> transaction)
        {
            if (transaction == null )
            {
                return NoContent();
            }
            try
            {
                List<Debtor> debtors = moneyTransfer.Make(transaction);
                return Ok(debtors);
            }
            catch (Exception)
            {
                return BadRequest();
            }
            
        }
    }
}