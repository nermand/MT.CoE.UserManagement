var Users = Backbone.Collection.extend({
    model: UserModel,
    count: function () {
        return this.filter(function (n) { return n.get('name'); });
    }
});