var app = new Vue({
    el: '#app',
    data: {
        price: 0,
        showPrice: true,
        loading:false
    },
    methods: {
        togglePrice: function () {
            this.showPrice = !this.showPrice;
        },
        alert(v) {
            alert(v);
        },
        getProducts() {
            this.loading = true;
            axios.get('/admin/products')
                .then(res => {
                    console.log(res);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        }
    },
    computed: {
        formatPrice:function() {
            return "$" + this.price;
        }
    }
})

//this. means everything inside app object...