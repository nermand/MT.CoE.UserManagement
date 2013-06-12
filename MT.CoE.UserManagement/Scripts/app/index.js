function Task(data) {
    this.title = ko.observable(data.title);
    this.isDone = ko.observable(data.isDone);
    this.taskType = ko.observable(data.taskType);
}

function TaskListViewModel() {
    var self = this;
    
    //fields - binding elements
    self.tasks = ko.observableArray([]);
    self.newTaskText = ko.observable('');
    self.incompleteTasks = ko.computed(function () {
        var incompleteTasksTotal = 0;
        ko.utils.arrayForEach(self.tasks(), function (task) {
            var value = task.isDone();
            if (value == undefined || !value) {
                incompleteTasksTotal++;
            }
        });
        return incompleteTasksTotal;
    }, self);
    self.taskTypes = initTaskTypes();
    
    //methods
    self.addTask = function () {
        self.tasks.push(new Task({ title: this.newTaskText() }));
        self.newTaskText("");
    };

    self.removeTask = function (task) {
        self.tasks.remove(task);
    };

    self.save = function () {
        //map KO object to MVC object
//        var tasks = [];
//        $.each(self.tasks(), function (i, item) {
//            var task = {};
//            task.Title = item.title();
//            task.IsDone = item.isDone();
//            task.TaskType = item.taskType();
//            tasks.push(task);
//        });
        function serverTask(title, isDone, taskType) {
            this.Title = title;
            this.IsDone = isDone;
            this.TaskType = taskType;
        }

        var mappedData = ko.utils.arrayMap(self.tasks(), function (item) {
            return new serverTask(item.title(), item.isDone(), item.taskType());
        });
        
        //send data to server
        var json = { 'tasks': mappedData };
        $.ajax({
            url: '/home/SaveForm',
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(json),
            contentType: 'application/json; charset=utf-8',
            success: function (data) {
                console.log("Success: " + data.success + ". Saved list of " + data.listSize + " element(s).");
            }
        });
    };

    //get data from server - initial load
    $.getJSON("/Home/TaskList", function (data) {
        var tasks = [];
        $.each(data, function (i, item) {
            var task = {};
            task.title = item.Title;
            task.isDone = item.IsDone;
            task.taskType = item.TaskType;
            tasks.push(new Task(task));
        });
        self.tasks(tasks);
    });
}

function initTaskTypes() {
    var returnVal;
    $.ajaxSetup({
        async: false
    });
    $.getJSON("/Home/GetTaskTypes", function (data) {
        var taskTypes = [];
        $.each(data, function (i, item) {
            var taskType = {};
            taskType.type = item.Type;
            taskType.id = item.Id;
            taskTypes.push(taskType);
        });
        returnVal = taskTypes;
    });
    return returnVal;
}

ko.applyBindings(new TaskListViewModel());