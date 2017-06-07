namespace ForgePlay

module LeapYear = 

  let isDivisibleBy year divisor =
    year % divisor = 0

  let isLeapYear (year : int) : bool = 
    let yearIsDivisibleBy divisor =
      isDivisibleBy year divisor

    match year with
    | _ when yearIsDivisibleBy 4 && yearIsDivisibleBy 400 -> true
    | _ when yearIsDivisibleBy 4 && yearIsDivisibleBy 100 -> false
    | _ when yearIsDivisibleBy 4 -> true
    | _ -> false
