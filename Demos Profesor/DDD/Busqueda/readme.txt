Four tenets of Onion Architecture:
http://jeffreypalermo.com/blog/the-onion-architecture-part-1/

The application is built around an independent object model
Inner layers define interfaces.  Outer layers implement interfaces
Direction of coupling is toward the center
All application core code can be compiled and run separate from infrastructure