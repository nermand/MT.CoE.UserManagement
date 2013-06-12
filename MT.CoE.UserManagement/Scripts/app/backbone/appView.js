var SearchView = Backbone.View.extend({
    initialize: function () {
        console.log("View initialized");
        this.render();
    },
    render: function () {
        var variables = { search_label: "Searchaj" };
        var template = _.template($("#search_template").html(), variables);
        this.$el.html(template);
    },
    events: {
        "click input[type=button]": "doSearch",
        "keyup #search_input": "updateModel"
    },
    doSearch: function (event) {
        console.log("Button clicked! Searched for " + person.get("name"));
    },
    updateModel: function (event) {
        person.set({ name: $("#search_input").val() });
    }
});

var search_view = new SearchView({el: $("#search_container") });