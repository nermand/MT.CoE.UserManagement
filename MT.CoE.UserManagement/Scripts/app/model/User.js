var UserModel = Backbone.Model.extend({
    initialize: function () {
        console.log("New User created: " + this.get("firstName"));
    },
    //url: "User/Test",

    defaults: {
        id: -1,
        firstName: 'DefaultName',
        lastName: 'DefaultLastName'
    }
});
