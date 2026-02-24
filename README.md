# Mobo Bank Mock API

## Project Overiew
This project was built to provide a mock banking API that handles enquiries via USSD, Mobile and Web channels

## Architecture
The system consists of:
- A client (Web App)
- A C# ASP.NET Core REST API

## Technology Used
- C# ASP.NET Core Web API (Backend)
- HTML, CSS, JavaScript (Frontend)
- Postman (API Testing)

## How to run the API
1. Navigate to the BankingAPI folder
2. Run `dotnet run`
3. API will start on `http://localhost:5120`
4. Test endpoint: POST `http://localhost:5120/api/Accounts/balance`

## API Endpoint
**POST** `/api/Accounts/balance`

**Request body**:
```JSON
    {
        "transaction_reference": "MP90023",
        "transaction_code": "BIMM",
        "amount": 0,
        "narration": "Payment for Order 8923",
        "phone_number": "254706215505"
    }
```
**Response body**
```JSON
    {
        "transaction_reference": "MP90023",
        "transaction_code": "BIMM",
        "amount": 0,
        "account_name": "John Doe",
        "phone_number": "254706215505",

        "actual_balance": 500,
        "available_balance": 500
    }
```

## Repository
https://github.com/LeigeMacharia/Mobo-mockBankAPI

