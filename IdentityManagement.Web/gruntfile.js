module.exports = function (grunt) {

    // 1. All configuration goes here 
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),

        copy: {
            pkg: {
                files: [
                    {// copy all class files and rename to .cs.pp
                        expand: true,
                        cwd: 'Areas/IdentityManagement/',
                        src: ['**/*.cs'],
                        filter: 'isFile',
                        dest: '../IdentityManagement/content/Areas/IdentityManagement/',
                        ext: '.cs.pp'
                    },
                    {// copy all view files and rename to .cshtml.pp
                        expand: true,
                        cwd: 'Areas/IdentityManagement/',
                        src: ['**/*.cshtml'],
                        filter: 'isFile',
                        dest: '../IdentityManagement/content/Areas/IdentityManagement/',
                        ext: '.cshtml.pp'
                    },
                    {// copy the views web.confg
                        expand: true,
                        cwd: 'Areas/IdentityManagement/Views/',
                        src: ['web.config'],
                        filter: 'isFile',
                        dest: '../IdentityManagement/content/Areas/IdentityManagement/Views/'
                    },
                    {// copy identity model class files and rename to .cs.pp
                        expand: true,
                        cwd: 'Models/',
                        src: ['ApplicationRoleManager.cs', 'ApplicationUserManager.cs', 'IdentitySettings.cs'],
                        filter: 'isFile',
                        dest: '../IdentityManagement/content/Models/',
                        ext: '.cs.pp'
                    }],
            }
        },
        replace: {
            pkg: {// do .pp file replacements
                src: ['../IdentityManagement/content/**/*.pp'],
                overwrite: true,                 
                replacements: [{
                    from: /IdentityManagement.Web/g,
                    to: '$rootnamespace$'
                }]
            }
        }
    });
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-text-replace');
    grunt.registerTask('default', ['copy:pkg', 'replace:pkg']);
};