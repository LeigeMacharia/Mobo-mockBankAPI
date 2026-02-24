const checkBalance = document.getElementById("checkBalanceBtn");
const result = document.getElementById("result");
const accountName = document.getElementById("accountName");
const actualBalance = document.getElementById("actualBalance");
const availableBalance = document.getElementById("availableBalance");
const errorMessage = document.getElementById("errorMessage");

checkBalanceBtn.addEventListener("click", async () => {
    const requestData = {
        transaction_reference: "MP90023",
        transaction_code: "BIMM",
        amount: 0,
        narration: "Payment for Order 8923",
        phone_number: "254706215505"
    };

    try {
        const response = await fetch("http://localhost:5120/api/accounts/balance", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(requestData)
        });

        if (!response.ok) {
            errorMessage.textContent = "Please try again";
            return
        }

        const data = await response.json();

        accountName.textContent = data.account_name;
        actualBalance.textContent = data.actual_balance;
        availableBalance.textContent = data.available_balance;

        result.classList.remove("hidden");
        errorMessage.textContent = "";

    } catch (error) {
        errorMessage.textContent = "Couldn't connect to the API";
        console.error(error);
    }
});