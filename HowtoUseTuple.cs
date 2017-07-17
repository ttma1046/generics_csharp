Tuple<string, Contact> keyValuePair;


keyValuePair =
  Tuple.Create("555-55-5555", new Contact("Inigo Montoya"));

keyValuePair =
  new Tuple<string, Contact>("555-55-5555", new Contact("Inigo Montoya"));
