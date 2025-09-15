using Builder_pattern;
//wrong way to create object
CellPhone cellPhone = new CellPhone("iPhone 13", "iOS", 6, 6.1m, 12, 3095);

Console.WriteLine(cellPhone.ToString());

//right way to create object using builder pattern
CellPhone cellPhone1 = new CellPhoneBuilder()
    .SetModel("iPhone 13")
    .SetOS("iOS")
    .SetRAM(6)
    .SetScreenSize(6.1m)
    .SetCamera(12)
    .SetBattery(3095)
    .Build();

Console.WriteLine(cellPhone1.ToString());
