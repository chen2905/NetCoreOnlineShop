var app = new Vue({
    el: '#app',
    data: {
        loading: false,
        productModel: {
            id: 0,
            name: "Product Name",
            description: "Product Description",
            value: 1.99
        },

        products:[]
    },
    methods: {
       
        getProducts() {
            this.loading = true;
            axios.get('/admin/products')
                .then(res => {
                    this.products = res.data;
                    console.log(res);
                })
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createProduct() {
            this.loading = true;
            axios.post('/Admin/products', this.productModel)
                .then(res => {
                    console.log(res.data);
                    this.products.push(res.data);
                    
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
        
    }
})

//this. means everything inside app object...