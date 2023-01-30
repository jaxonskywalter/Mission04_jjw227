$(document).ready(function () {
    $('#gradeForm').submit(function (event) {
        event.preventDefault();

        //creates variables that are equal to the inputs multiplied by the sylabus weights
        let assignments = $('#assignments').val() * 0.5;
        let groupProject = $('#groupProject').val() * 0.1;
        let quizzes = $('#quizzes').val() * 0.1;
        let midtermExam = $('#midtermExam').val() * 0.1;
        let finalExam = $('#finalExam').val() * 0.1;
        let intex = $('#intex').val() * 0.1;

        //adds of the weights to get a final percentage
        let finalPercentage = assignments + groupProject + quizzes + midtermExam + finalExam + intex;

        //links the results of the functions back to the form to print
        $('#letterGrade').text('Final Percentage: ' + finalPercentage.toFixed(2) + '%' + ' Letter Grade: ' + getLetterGrade(finalPercentage));
    });

    //calculates the letter grade based off of the final percentage
    function getLetterGrade(percentage) {
        if (percentage >= 90) {
            return 'A';
        } else if (percentage >= 80) {
            return 'B';
        } else if (percentage >= 70) {
            return 'C';
        } else if (percentage >= 60) {
            return 'D';
        } else {
            return 'F';
        }
    }
});
