using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyVaultCommon;

namespace MyVaultKeepWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyVaultKeepController : ControllerBase
    {
        private readonly Functions_BusinessLogic.SavingsProcess _SavingsProcess;

        public MyVaultKeepController(Functions_BusinessLogic.SavingsProcess savingsProcess)
        {
            _SavingsProcess = savingsProcess ?? throw new ArgumentNullException(nameof(savingsProcess));
        }

        [HttpPatch("Withdraw")]
        public bool Withdraw(double amount)
        {
            var userInput = Functions_BusinessLogic.TransactionActions.Withdraw;

            var result = Functions_BusinessLogic.DepositAndWithdrawal.VaultProcess(userInput, amount);

            return result;
        }

        [HttpPatch("Deposit")]
        public bool Deposit(double amount)
        {
            var userInput = Functions_BusinessLogic.TransactionActions.Deposit;

            var result = Functions_BusinessLogic.DepositAndWithdrawal.VaultProcess(userInput, amount);

            return result;
        }

        [HttpPost("CreateSavings")]
        public bool CreateSavings(string name, double amountSavings)
        {
            var userInput = Functions_BusinessLogic.TransactionActions.Savings;
            var result = _SavingsProcess.createSavings(userInput, name, amountSavings);
            return result;
        }

        [HttpDelete("DeleteSavings")]
        public bool DeleteSavings(string name, double amount)
        {
            var userInput = Functions_BusinessLogic.TransactionActions.Savings;
            var result = _SavingsProcess.deleteSavings(userInput, name, amount);
            return result;
        }

        [HttpPut("UpdateSavings")]
        public bool UpdateSavings(string oldName, string newName, double newAmount)
        {
            var userInput = Functions_BusinessLogic.TransactionActions.Savings;
            var result = _SavingsProcess.updateSavings(userInput, oldName, newName, newAmount);
            return result;
        }

        [HttpPost("Expenses")]
        public bool CreateExpenses(double amount)
        {
            var userInput = Functions_BusinessLogic.TransactionActions.Expenses;
            var result = Functions_BusinessLogic.ExpensesProcess.initializeExpenses(userInput, amount);

            return result;
        }
    }
}


