var Users = Backbone.Collection.extend({
    model: UserModel,
    
    url: "Admin/UserList",
    
    parse: function (response) {
        
        var parsedList = [];
        _(response).each(function (user) {
            var userModel = new UserModel({
                id: user.Id,
                firstName: user.FirstName,
                lastName: user.LastName,
                picUrl: user.PicUrl,
                description: user.JobDescription,
                companyName: user.CompanyName,
                address: user.Address,
                postalCode: user.PostalCode,
                cityName: user.CityName,
                country: user.Country
            });
            parsedList.push(userModel);

        });
        return parsedList;
    },

    count: function () {
        return this.filter(function (n) { return n.get('firstName'); });
    }
    //,save: function () {
    //    Backbone.sync('create', this, {
    //        success: function () {
    //            console.log('users saved!');
    //        }
    //    });
    //}
});