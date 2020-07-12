/// <binding />
var gulp = require('gulp'),
    sass = require('gulp-sass');

gulp.task('build-css', function () {
    return gulp
        .src('./wwwroot/sass/**/*.scss')
        .pipe(sass())
        .pipe(gulp.dest('./wwwroot/css'));
});

// Default Task
gulp.task('default', gulp.series('build-css'));