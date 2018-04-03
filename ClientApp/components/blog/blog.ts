import Vue from "vue";
import { Component } from "vue-property-decorator";

interface Blog {
  title: string;
  id: number;
  postDate: string;
  postBody: string;
}

@Component
export default class FetchDataComponent extends Vue {
  blogs: Blog[] = [];

  mounted() {
    fetch("api/Blog/")
      .then(response => response.json() as Promise<Blog[]>)
      .then(data => {
        this.blogs = data;
      });
      
  }
}
