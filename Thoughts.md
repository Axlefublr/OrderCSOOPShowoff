Shouldn't most setters be private protected? You set stuff when you create the object using the constructor

I guess you should leave them available sometimes, if say the user decides to change their address

Addresses will be different depending on the type of the delivery, so the Address property should be abstract