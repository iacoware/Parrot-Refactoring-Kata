# From procedural polymorphism to OO polymorphism in small safe steps

What should be polymorphic?
  - Parrot?
  - ParrotType?

- Replace ctor with factory method
- Introduce a derived class for each enum case
- Choose one  subclass
  - override GetSpeed() and take the implementation from the specific case of the switch
  - return chosen class from factory method
  - remove case from original switch
  
- Repeat until every subclass has been implemented
- Make base class abstract (_type becomes unused)
- Push members down (GetLoadFactor, GetBaseSpeed)
- Push instance field down (noOfCoconuts, voltage, isNailed)
  - clean up ctors
- Test: Invoke specific ctor 
- Remove factory method which shouldn't be used anymore