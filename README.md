# Decorator-Design-Patterns
The example of decorator work and strong inheritance functionalities.
# General Description
There are three types of toys: doll, warrior and a race driver. 
They implement IToy interface which contains methods:
1. float Cost() - returns a total cost of a toy.
2. string Summary() - returns a string describing the toy and all its features.
# Features in the task
1. Adding sword to a toy. Increases cost by 15 and adds a description line.
2. Adding a helmet to a toy. Increases cost by 10 and adds a description line.
3. Wearing a dress. May be flowered (+20 to cost) or dotted (+19.99 to cost). Adds a description.
4. Adding a method float Height() to every toy. Adding a line about height.
5. Implementing a possibility of jumping. Increases cost by 20. Each consecutive jump is shorter by 10 percent points (50%,40%,30%,20%,10%). After 5 jumps description adds no additional line. 
6. Adding possibility of dancing. Breakdance +50 to cost. Solo Capoeira +70. Gangnam Style +100. Adding a proper description. There can be added any number of dances.
7. Possibility of storytelling. Can be scary or a joke. Both add +30 to cost and a proper description.
# New toys
1. Minotaur - has a name, age, height, mass. 
2. Centaur - has a name, age, height, information if he has a beard.
Both cost 250 and every functionality can be added.
