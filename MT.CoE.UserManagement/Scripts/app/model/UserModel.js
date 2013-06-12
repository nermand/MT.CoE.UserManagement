var UserModel = Backbone.Model.extend({
    initialize: function () {
        console.log("New User created: " + this.get("name"));
    },

    defaults: {
        id: -1,
        name: 'DefaultName',
        city: 'DefaultCity',
        age: 0,
        skilld: []
    }
});
