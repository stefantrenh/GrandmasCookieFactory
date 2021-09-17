var app = new Vue(
    {
        el: '#app',
        data: {
            inputs: [{
                key: '',
                value: ''
            }],

        },
        mounted() {
            
        },
        methods: {
            add() {
                this.inputs.push({
                    key: '',
                    value: ''
                })
                console.log(this.inputs)
            },

            remove(index) {
                this.inputs.splice(index, 1)
            },

        }
    })