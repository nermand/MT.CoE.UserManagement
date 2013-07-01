var AdminView = Backbone.View.extend({
    el: $("#user-list"),

    initialize: function () {
        $("#user").hide();
        _.bindAll(this, 'render', 'appendUser', 'editUser', 'addUser', 'deleteUser', 'selectUser');
        this.collection = new Users();
        this.collection.bind('add', this.appendUser);

        this.collection.fetch();
    },

    events: {
        'click button#edit': 'editUser',
        'click button#add': 'addUser',
        'click button#delete': 'deleteUser',
        'click div.edit-user': 'selectUser'
    },

    appendUser: function (item) {
        var variables = {
            userId: item.get("id"),
            firstName: item.get("firstName"),
            lastName: item.get("lastName"),
            phoneNumber: item.get("phoneNumber"),
            description: item.get("description"),
            companyName: item.get("companyName"),
            address: item.get("address"),
            postalCode: item.get("postalCode"),
            cityName: item.get("cityName"),
            country: item.get("country"),
            picUrl: item.get("picUrl")
        };
        var template = _.template($("#user_template").html(), variables);
        $('ul', $(this.el)).append(template);
    },

    editUser: function () {
        var selectedDiv = $("div.basic.selected");
        var userId = selectedDiv.data('id');
        if (typeof userId !== 'number') {
            alert("Select user you want to edit!");
            return;
        }
        
        $("#user-list").hide("explode", 1000, function () {
            window.location.href = "/EditUser--Ervin?/" + userId;
        });
        
    },

    addUser: function () {
        alert('Redirect to page where admin can add new user..');
    },

    deleteUser: function () {
        var selectedDiv = $("div.basic.selected");
        var userId = selectedDiv.data('id');
        if (typeof userId !== 'number') {
            alert("Select user you want to delete!");
            return;
        }
        var thisUser = this.collection.get(userId);
        this.collection.remove(thisUser);
        selectedDiv.hide("fold", 800, function() {
            selectedDiv.remove();
            alert('Deleted from DOM - not implemented on DB, don\'t feel like doing it :)');
        });
    },
    
    selectUser: function (e) {
        var thisUser = $(e.currentTarget);
        $("div.basic").removeClass("selected");
        thisUser.closest(".basic").addClass("selected");
        //console.log("Editing current user", thisUser.find("span:first").text(), thisUser.closest(".basic").data("id"));
    }    
});