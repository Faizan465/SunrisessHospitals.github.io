// JavaScript Document
$(document).ready(function() {

    "use strict";

    $(".contact-form").submit(function(e) {
        e.preventDefault();
        var Name = $(".Name");
        var Email = $(".Email");
        var PhoneNumber = $(".PhoneNumber");
        var Haveuvisitbefore = $(".Haveuvisitbefore");
        var Subject = $(".Subject");
        var Message = $(".Message");
        var flag = false;
        if (Name.val() == "") {
            Name.closest(".form-control").addClass("error");
            Name.focus();
            flag = false;
            return false;
        } else {
            Name.closest(".form-control").removeClass("error").addClass("success");
        } if (Email.val() == "") {
            Email.closest(".form-control").addClass("error");
            Email.focus();
            flag = false;
            return false;
        } else {
            Email.closest(".form-control").removeClass("error").addClass("success");
        } if (Phonemunber.val() == "") {
            Phonemunber.closest(".form-control").addClass("error");
            Phonemunber.focus();
            flag = false;
            return false;
        } else {
            Phonemunber.closest(".form-control").removeClass("error").addClass("success");
        } if (Haveuvisitbefore.val() == "") {
            Haveuvisitbefore.closest(".form-control").addClass("error");
            Haveuvisitbefore.focus();
            Haveuvisitbefore = false;
            return false;
        } else {
            Haveuvisitbefore.closest(".form-control").removeClass("error").addClass("success");
        } if (Subject.val() == "") {
            Subject.closest(".form-control").addClass("error");
            Subject.focus();
            flag = false;
            return false;
        } else {
            Subject.closest(".form-control").removeClass("error").addClass("success");
        } if (Message.val() == "") {
            Message.closest(".form-control").addClass("error");
            Message.focus();
            flag = false;
            return false;
        } else {
            Message.closest(".form-control").removeClass("error").addClass("success");
            flag = true;
        }
        var dataString = "Name=" + Name.val() + "&Email=" + Email.val() + "&Phonemunber=" + Phonemunber.val() + "&Haveuvisitbefore=" + Haveuvisitbefore.val() + "&Subject=" + Subject.val() + "&Message=" + Message.val();
        $(".loading").fadeIn("slow").html("Loading...");
        $.ajax({
            type: "POST",
            data: dataString,
            url: "@Url.Action('Contact','Create')",
            cache: false,
            success: function (d) {
                $(".form-control").removeClass("success");
                    if(d == 'success') // Message Sent? Show the 'Thank You' message and hide the form
                        $('.loading').fadeIn('slow').html('<font color="#48af4b">Mail sent Successfully.</font>').delay(3000).fadeOut('slow');
                         else
                        $('.loading').fadeIn('slow').html('<font color="#ff5607">Mail not sent.</font>').delay(3000).fadeOut('slow');
                                }
        });
        return false;
    });
    $("#reset").on('click', function() {
        $(".form-control").removeClass("success").removeClass("error");
    });
    
})



