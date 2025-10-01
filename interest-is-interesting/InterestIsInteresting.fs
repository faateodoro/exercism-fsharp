module InterestIsInteresting

let interestRate (balance: decimal): single =
   match balance with
   | x when x < 0.0m -> 3.213f
   | x when x < 1000.0m -> 0.5f
   | x when x < 5000.0m -> 1.621f
   | _ -> 2.475f

let interest (balance: decimal): decimal =
   balance / 100m * decimal (interestRate balance)

let annualBalanceUpdate(balance: decimal): decimal =
   balance + interest balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
   match balance with
      | x when x <= 0m -> 0
      | _ -> int (balance * decimal taxFreePercentage / 100m * 2m)
