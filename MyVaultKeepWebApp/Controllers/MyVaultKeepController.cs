using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyVaultCommon;
using Functions_BusinessLogic;

namespace MyVaultKeepWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyVaultKeepController : ControllerBase
    {

        [HttpPatch("Withdraw")]
        public bool Withdraw(double amount)
        {
            var userInput = TransactionActions.Withdraw;

            var result = DepositAndWithdrawal.VaultProcess(userInput, amount);

            return result;
        }

        [HttpPatch("Deposit")]
        public bool Deposit(double amount)
        {
            var userInput = TransactionActions.Deposit;

            var result = DepositAndWithdrawal.VaultProcess(userInput, amount);

            return result;
        }

        [HttpPost("CreateSavings")]
        public bool CreateSavings(string name, double amountSavings)
        {
            var userInput = TransactionActions.Savings;
            var result = SavingsProcess.createSavings(userInput, name, amountSavings);
            return result;
        }

        [HttpDelete("DeleteSavings")]
        public bool DeleteSavings(string name, double amount)
        {
            var userInput = TransactionActions.Savings;
            var result = SavingsProcess.deleteSavings(userInput, name, amount);
            return result;
        }

        [HttpPut("UpdateSavings")]
        public bool UpdateSavings(string oldName, string newName, double newAmount)
        {
            var userInput = TransactionActions.Savings;
            var result = SavingsProcess.updateSavings(userInput, oldName, newName, newAmount);
            return result;
        }

        [HttpPost("Expenses")]
        public bool CreateExpenses(double amount)
        {
            var userInput = TransactionActions.Expenses;
            var result = ExpensesProcess.initializeExpenses(userInput, amount);

            return result;
        }
    }
}
