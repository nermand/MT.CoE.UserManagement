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
        'click a#edit': 'editUser',
        'click a#add': 'addUser',
        'click a#delete': 'deleteUser',
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
            alert('Editing user id: ' + userId);
            //window.location.href = "/EditUser--Ervin?/" + userId;
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
        thisUser.deleteUser(function (result, text) {
            if (result) {
                selectedDiv.hide("fold", 800, function () {
                    selectedDiv.remove();
                });
            }
            alert(text);
        });
  
    },
    
    selectUser: function (e) {
        var thisUser = $(e.currentTarget).parent("div");
        $("div.basic").removeClass("selected");
        thisUser.closest(".basic").addClass("selected");
        thisUser.parent().find("div:first").before(thisUser.clone());
        thisUser.remove();
        $(window).scrollTop($('#user-list').offset().top);
    }    
});