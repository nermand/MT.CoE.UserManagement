var Person = Backbone.Model.extend({
    initialize: function () {
        console.log("Person model initialized!");
        this.on("change:name", function (model) {
            var name = model.get("name");
            console.log("Event fired - name changed to " + name);
        });
    },
    defaults: {
        name: 'Fetus',
        age: 0,
        child: ''
    },
    urlRoot: '/Home/Person'
});

var person = new Person();

person.set({
    name: 'Nerman',
    age: 33,
    child: 'None'
});


//console.log("Show name: " + person.get("name"));
//console.log("keys");
//console.log(_.keys(person.attributes));
//console.log("values");
//console.log(_.values(person.attributes));
//console.log("methods");
//console.log(_.functions(person));


function MappedPerson(person) {
    var obj = { };
    obj.Name = person.get("title");
//    obj.City = person.get("city");
//    obj.ZipCode = person.get("zipCode");
    obj.Age = person.get("age");

    return obj;
}

////Saving
//var mappedUser = new MappedPerson(person);

//person.save(mappedUser, {
//    success: function(user) {
//        console.log(user.toJSON());
//    }
//});

