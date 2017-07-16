$(document).ready(function() {
    $('div.tree-add-member').popover({
        title: "<h1><strong>HTML</strong> inside <code>the</code> <em>popover</em></h1>",
        content: "Blabla <br> <h2>Cool stuff!</h2>",
        html: true,
        placement: "right",
        trigger: "hover"
    });
});