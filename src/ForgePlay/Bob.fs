namespace ForgePlay

module Bob = 

  let responses = dict [
    "statement", "Whatever.";
    "yell", "Whoa, chill out!";
    "question", "Sure.";
    "silence", "Fine. Be that way!";
    "default", "Whatever."
  ]
  let hey message:string = 
    let upperCount = 
      Seq.filter(System.Char.IsUpper) message
      |> Seq.length
    if upperCount > 2 then responses.Item("yell") else responses.Item("default")
