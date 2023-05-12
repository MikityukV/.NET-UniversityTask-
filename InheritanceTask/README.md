# Explain for "InheritanceTask" file
This code is an example of class inheritance in the C# programming language. It defines three classes: region, city, and megapol.

The region class has three properties: Name, Pop, and Cities, which represent the name of the region, the population, and an array of cities in this region respectively. The constructor of the region class takes parameters name, pop, and cities and sets the corresponding properties.

The city class inherits from the region class and adds one property square, which represents the area of the city. The constructor of the city class calls the constructor of the base class region and sets the value of its new property square.

The megapol class inherits from the city class and overrides the Print() method of the region class. It also adds a constructor that calls the constructor of the base class city and calls the Print() method.

The MainClass class contains a Main() method that creates instances of the city and megapol classes, passing property values through their constructors. This is an example of using class inheritance to create more specialized classes based on base classes.
