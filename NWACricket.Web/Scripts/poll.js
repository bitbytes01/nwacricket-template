$(function () {

    $('.submit-poll').live('click', formProcess);

    if ($(".poll-results").length > 0) {
        var conatiners = $('.poll-container');
        conatiners.each(function () {
            animateResults($(this));
        });
    }

    $("#accordion").accordion({
        heightStyle: "content",
        autoHeight: false
    });
});

function formProcess(event) {
    event.preventDefault();

    var $trigger = event.target,
        $parent = $($trigger).parent('.poll-container div'),
        $checkedRadio = $parent.find('input[type=radio]:checked'),
        $selectedTeam = $checkedRadio.attr("value"),
        $matchId = $checkedRadio.attr("data-matchid"),
        pollArray = JSON.parse(localStorage.getItem('polls')) || [];
    if ($matchId) {
        if ($.inArray($matchId, pollArray) !== -1) {
            $selectedTeam = '';
        } else {
            pollArray.push($matchId);
            localStorage.setItem("polls", JSON.stringify(pollArray));
        }

        $.getJSON($parent.closest('section').attr('data-url'), { matchId: $matchId, teamId: $selectedTeam }, function (data) {
            loadResults(data, $parent);
        });
    }
}

function animateResults(container) {
    container.find(".poll-results").find('div').each(function () {
        var percentage = $(this).next().text();
        $(this).css({ width: "0%" }).animate({
            width: percentage
        }, 'slow');
    });
}

function loadResults(data, container) {

    var totalVotes = parseInt(data.TeamOneVotes) + parseInt(data.TeamTwoVotes),
       teamOnepercent = Math.round((parseInt(data.TeamOneVotes) / parseInt(totalVotes)) * 100),
        teamTwopercent = Math.round((parseInt(data.TeamTwoVotes) / parseInt(totalVotes)) * 100),
        resultsHtml = "<div class='poll-left poll-results'><h3>Poll Results</h3>\n<dl class='graph'>\n";

    resultsHtml = resultsHtml + "<dt class='bar-title'>" + data.TeamOne + "</dt><dd class='bar-container'><div id='bar" + data.TeamIdOne + "'style='width:0%;'>&nbsp;</div><strong>" + teamOnepercent + "%</strong></dd>\n";
    resultsHtml = resultsHtml + "<dt class='bar-title'>" + data.TeamTwo + "</dt><dd class='bar-container'><div id='bar" + data.TeamIdTwo + "'style='width:0%;background-color:#0066cc;'>&nbsp;</div><strong>" + teamTwopercent + "%</strong></dd>\n";

    resultsHtml = resultsHtml + "</dl><p>Total Votes: <strong> " + totalVotes + "</strong></p></div>\n";

    container.html(resultsHtml).fadeIn("slow", function () {
        animateResults(container);
    });
}