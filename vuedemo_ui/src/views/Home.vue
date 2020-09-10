<template>
<div id="homePage">
    <aside>
        <div class="left-pad">
            <p class="left-title">Recommended List</p>
            <ul>
                <li v-for="item in getMarketListByRecommend" :key="item.id">
                    {{item.marketItemTitle}}
                </li>
            </ul>
        </div>
        <div class="left-pad">
            <p class="left-title">Search</p>
            <div class="search-pad">
                <input type="text" v-model="searchText" placeholder="Please input the key words here" />
                <button v-on:click="search()">Search</button>
            </div>
        </div>
        <div class="left-pad">
            <p class="left-title">Contact Us</p>
            <div class="contact-pad">
                <p>XXX Company Ltd.</p>
                <p>Phone：03-8888 8888</p>
            </div>
        </div>
    </aside>
    <article v-show="showSearch == false">
        <div class="art-pad" v-for="type in types" :key="type.id">
            <p class="art-title">{{type.typeName}}</p>
            <ul>
                <li v-for="item in getMarketListByTypeId(type.id)" :key="item.id">{{item.marketItemTitle}}</li>
            </ul>
        </div>

    </article>
    <article v-show="showSearch == true">
        <p class="art-title">Search Result</p>
        <div class="back-all" v-on:click="backAll()" v-text="'<< Retrun'"> </div>
        <ul v-if="searchRes.length > 0 ">
            <li v-for="item in searchRes" :key="item.id">
                {{item.marketItemTitle}}
            </li>
        </ul>
        <div class="search-none"  v-else>
            There is no relevant result.
        </div>
    </article>

    <div class="clear-float"></div>
</div>
</template>

<script>
export default {
    data() {
        return {
            types: [],
            marketList: [],
            searchText: null,
            searchRes: [],
            showSearch: false,
        }
    },
    mounted() {
      this.getTypes();
      this.getMarketList();
    },
    methods: {
        getTypes() {
            var that = this;
            $.get("http://localhost:7330/Home/GetNavs", {}, function (res) {
                that.types = res;
            })
        },
        getMarketList() {
                var that = this;
                $.get("http://localhost:7330/Home/GetMarketList", {}, function (res) {
                    that.marketList = res;
                })
            },
        search() {
            if (this.searchText == null) {
              layer.msg("Please input something for the search");
            } else {
                this.searchRes = this.marketList.filter(m => m.marketItemTitle.includes(this.searchText));
                this.showSearch = true;
            }

        },
        backAll() {
            this.showSearch = false;
            this.searchText = null;
        }
    },
    computed: {
        getMarketListByRecommend() {
                return this.marketList.filter(m => m.isRecommend == true);
            },
        getMarketListByTypeId() {
                return function (typeId) {
                    return this.marketList.filter(m => m.typeId == typeId);
                }
            }
    }
}
</script>

<style scoped>
#homePage {
    width: 1240px;
    margin: auto;
    background-color: #fff;
    padding: 0 20px;
}

#homePage aside {
    float: left;
    width: 300px;
    margin-top: 6px;
    border-left: 2px solid #134398;
    border-right: 2px solid #134398;
    border-bottom: 2px solid #134398;
    border-radius: 6px;
}

#homePage aside .left-pad p.left-title {
    background-color: #134398;
    color: #fff;
    height: 40px;
    line-height: 40px;
    padding: 0 10px;
}

#homePage aside ul li {
    padding: 2px 10px;
    list-style: none;
}

#homePage aside .search-pad p {
    padding-left: 6px;
    margin: 3px 10px !important;
}

#homePage aside .search-pad input {
    padding-left: 6px;
    margin: 3px 10px !important;
    border: 1px solid #ccc;
    width: 258px;
}

#homePage aside .search-pad .txt-none {
    border: 1px solid red;
}

#homePage aside .search-pad button {
    padding-left: 6px;
    margin: 3px 10px 16px 10px !important;
    width: 258px;
    background-color: #0094ff;
    border: 1px solid #0094ff;
    height: 30px;
    font-size: 13px;
    color: #fff;
}

#homePage aside .contact-pad p {
    margin: 3px 10px 3px 10px;
}

#homePage aside .contact-pad {
    padding-bottom: 10px;
}

#homePage .clear-float {
    clear: both;
}

#homePage article {
    float: left;
    margin-left: 0;
    width: 908px;
    margin-top: 6px;
}

#homePage article .art-pad {
    width: 440px;
    border: 2px solid #134398;
    height: 400px;
    float: left;
    margin-left: 10px;
    margin-bottom: 10px;
    border-radius: 6px;
}

#homePage article .art-title {
    background-color: #134398;
    color: #fff;
    height: 40px;
    line-height: 40px;
    padding: 0 10px;
}

#homePage article ul li {
    list-style: none;
    padding: 6px 10px;
    cursor: pointer;
}

#homePage .back-all {
    font-size: 13px;
    padding: 12px;
    cursor: pointer;
}

#homePage .search-none {
    font-size: 13px;
    padding: 12px;
}
</style>
