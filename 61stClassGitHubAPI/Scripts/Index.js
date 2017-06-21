$(function () {

    $("#search-button").on("click", function () {
        $.get("/home/GetInfo", { login: $("#login").val() }, function (result) {
            console.log(result);
            var name = result.ghUser.name;
            var location = result.ghUser.location;
            $("#titletxt").append(name," ", location);

            $("table tr:gt(0)").remove();
            result.ghRepos.forEach(function (repo) {
                $("table").append(`<tr><td>${repo.name}</td><td>${repo.description}</td><td>${repo.language}</td><td>${repo.watchers}</td></tr>`);
            
            });
            $("#sort").on("click", function () {
                result.ghRepos.sort(function (a, b) {
                   
                    return a.watchers - b.watchers ;
                })
                $("table tr:gt(0)").remove();
                result.ghRepos.forEach(function (repo) {
                    $("table").append(`<tr><td>${repo.name}</td><td>${repo.description}</td><td>${repo.language}</td><td>${repo.watchers}</td></tr>`);

                });

            });
        });
    });
  
});
