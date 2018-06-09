import Vue from 'vue';
import { Component } from "vue-property-decorator";

@Component
export default class AdminComponent extends Vue {
    categories: Category[] =[
        {id: '1', name: 'cate 1'},
        {id: '2', name: 'cate 2'},
        {id: '3', name: 'cate 3'},
        {id: '4', name: 'cate 4'},
        {id: '5', name: 'cate 5'},
        {id: '5', name: 'cate 6'},
    ]
}

interface Category {
    id: string,
    name: string
}
