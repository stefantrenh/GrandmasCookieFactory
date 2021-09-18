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
            console.log(this.inputs);
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