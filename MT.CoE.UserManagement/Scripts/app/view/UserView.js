var UserView = Backbone.View.extend({
    el: $("#user-list"),

    events: {
        'click button#add': 'addItem',
        'click span.delete': 'deleteUser',
        'click button#save': 'saveUsers'
    },
    initialize: function () {
        _.bindAll(this, 'render', 'addItem', 'appendUser', 'deleteUser', 'saveUsers');

        this.collection = new Users();
        this.collection.bind('add', this.appendUser);

        this.collection.fetch();
        this.render();
        //var newUser = new UserModel({ id: jQuery.Guid.New(), name: "Nerman", age: 33, city: "Sarajevo" });
        //this.collection.add(newUser);


        //Backbone.sync('create', this.collection.models, {
        //    success: function () {
        //        console.log('users saved!');
        //    }
        //});
    },

    render: function () {
        var self = this;

        _(this.collection.models).each(function (user) {
            self.appendUser(user);
        });
    },

    appendUser: function (item) {
        var variables = { user_id: item.get("id"), user_name: item.get("name"), user_city: item.get("city"), user_age: item.get("age") };
        var template = _.template($("#user_template").html(), variables);
        $('ul', $(this.el)).append(template);
    },
    
    addItem: function () {
        var user = new UserModel();
        user.set({
            id: jQuery.Guid.New(),
            name: $("#user-name").val(),
            age: $("#user-age").val(),
            city: $("#user-city").val()
        });
        this.collection.add(user);
        console.log(this.collection.count().length);
    },

    deleteUser: function (e) {
        e.preventDefault();
        var $li = $(e.currentTarget).parent();
        var id = $li.data("id");
        var thisUser = this.collection.get(id);
        this.collection.remove(thisUser);
        $li.remove();
        console.log(this.collection.count().length);
    },

    saveUsers: function () {
        console.log('save?');
        this.collection.save();
    }
    

});