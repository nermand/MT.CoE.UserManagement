var AdminView = Backbone.View.extend({
    el: $("#user-list"),

    initialize: function () {
        $("#user").hide();
        _.bindAll(this, 'render', 'appendUser', 'addUser', 'saveUser', 'deleteUser');
        this.collection = new Users();
        this.collection.bind('add', this.appendUser);

        this.collection.fetch();
    },

    events: {
        'click button#add': 'addUser',
        'click button#save': 'saveUser',
        'click span.delete': 'deleteUser'
    },

    appendUser: function (item) {
        var variables = {
            user_id: item.get("id"),
            firstName: item.get("firstName"),
            lastName: item.get("lastName"),
            address: item.get("address"),
            birthDate: item.get("birthDate"),
            email: item.get("email"),
            phoneNo: item.get("phoneNo")
        };
        var template = _.template($("#user_template").html(), variables);
        $('ul', $(this.el)).append(template);
    },

    addUser: function () {
        console.log('Adding user..');
    },

    saveUser: function () {
        console.log('Saving user..');
    },

    deleteUser: function (e) {
        e.preventDefault();
        var $li = $(e.currentTarget).parent();
        var id = $li.data("id");
        var thisUser = this.collection.get(id);
        this.collection.remove(thisUser);
        $li.remove();
        console.log(this.collection.count().length);
    }
    
});