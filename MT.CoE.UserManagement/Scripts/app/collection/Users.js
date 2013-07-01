var Users = Backbone.Collection.extend({
    model: UserModel,
    url: "Admin/UserList",
    parse: function (response) {
        
        var parsedList = [];

        _(response).each(function (user) {
            var userModel = new UserModel({
                id: user.UserId,
                firstName: user.FirstName,
                lastName: user.LastName,
                birthDate: user.BirthDate,
                address: user.Address,
                phoneNo: user.PhoneNo,
                email: user.Email
            });
            parsedList.push(userModel);

        });
        return parsedList;
    },

    count: function () {
        return this.filter(function (n) { return n.get('id'); });
    },

    save: function () {
        Backbone.sync('create', this, {
            success: function () {
                console.log('users saved!');
            }
        });
    }
});