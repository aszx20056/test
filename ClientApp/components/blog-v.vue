<template>
  <div>
    Title:<br />
    <textarea v-model="blog.Title"></textarea><br />
    Content:<br />
    <textarea v-model="blog.Content"></textarea><br />
    <button type="button" class="btn alert-danger" @click="Add">SEND</button>
  </div>
</template>

<script>
  import qs from 'qs'
  export function test1(j94) {
    alert(j94);
  }
  export default {
    computed: {
    
    },
    mounted: function () {
    },
    data() {
      return {
        blog: { Title: '7894', Content: '', PostId: null }
      }
    },
    methods: {
      Add: function () {
        var self = this;
        var send = { jstr: JSON.stringify(self.blog), Title: 'test' }
        this.$http.post('api/Blog/Add', qs.stringify(send), { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } }).then(function () {
          
        });
      }
     
    }
  }
</script>

<style>

</style>
