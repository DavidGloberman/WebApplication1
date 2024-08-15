using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class JsonPlaceholderService
    {
        private readonly HttpClient _httpClient;

        public JsonPlaceholderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Item>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("https://fakestoreapi.com/products");
            response.EnsureSuccessStatusCode();
            var items = await response.Content.ReadFromJsonAsync<List<Item>>();
            return items;
        }


        public async Task<Item> CreatePostAsync(Item newItem)
        {
            var response = await _httpClient.PostAsJsonAsync("https://fakestoreapi.com/products", newItem);
            response.EnsureSuccessStatusCode();
            var createdItem = await response.Content.ReadFromJsonAsync<Item>();
            return createdItem;
        }

        public async Task<Item> GetPostAsync(int id)
        {
            var response = await _httpClient.GetAsync($"https://fakestoreapi.com/products/{id}");
            response.EnsureSuccessStatusCode();
            var post = await response.Content.ReadFromJsonAsync<Item>();
            return post;
        }

        public async Task UpdatePostAsync(int id, Item updatedPost)
        {
            var response = await _httpClient.PutAsJsonAsync($"https://fakestoreapi.com/products/{id}", updatedPost);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeletePostAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"https://fakestoreapi.com/products/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
