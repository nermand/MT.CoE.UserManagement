var People = Backbone.Collection.extend({
   model: Person
});

var person1 = new Person({ name: "Josip", age: 121 });
var person2 = new Person({ name: "Jovanka", age: 89 });
var person3 = new Person({ name: "Andrej", age: 39 });

var peopleCol = new People([person1, person2, person3]);
console.log(peopleCol.models);

