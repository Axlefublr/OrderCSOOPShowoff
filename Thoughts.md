Shouldn't most setters be private protected? You set stuff when you create the object using the constructor

I guess you should leave them available sometimes, if say the user decides to change their address

---

Addresses will be different depending on the type of the delivery, so the Address property should be abstract

---

No actually an address complier is a stupid idea, even for laughs

---

Should the Address classes be internal? 

My idea is for the Delivery classes to use the Address classes as types for the Address property

I think using a constrainer generic would be a good idea for this btw

Actually, no. It's better to be stricter than that and require the actual correct class, rather than giving the user an ability to use the wrong one

Back to normal ig

So to answer the initial question: no. 

Should be public because we'll need to create the instances of the Address classes that we can then pass into the Delivery classes

We might not access that directly though, in the end. So they will remain internal until they need to not be