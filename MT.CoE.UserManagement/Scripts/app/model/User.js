var UserModel = Backbone.Model.extend({
    initialize: function () {
        console.log("New User created: " + this.get("firstName"));
    },
    
    url: "Admin/SingleUser",
    
    defaults: {
        id: -1,
        firstName: 'DefaultName',
        lastName: 'DefaultLastName'
    },
    
    deleteUser: function (userId, callback) {
        //console.log("this", this);
        this.url += '/' + userId;
        //console.log('Url: ', this.url);
        this.destroy({
            success: function (model, response) {
                if (response.success) {
                    callback(true, 'User deleted successfully');
                }else {
                    callback(false, 'Problem with deleting user ' + response.error);
                }
            },
            error: function (model, xhr) {
                callback(false, 'Server Error on deleting user ' + xhr.status + ' ' + xhr.statusText);
            }
        });
    }
});
