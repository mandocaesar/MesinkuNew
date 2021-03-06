using System.Collections.Generic;
using SmartStore.Collections;
using SmartStore.Core.Domain.Catalog;
using SmartStore.Core;

namespace SmartStore.Services.Catalog
{
    /// <summary>
    /// Product attribute service interface
    /// </summary>
    public partial interface IProductAttributeService
    {
        #region Product attributes

        /// <summary>
        /// Deletes a product attribute
        /// </summary>
        /// <param name="productAttribute">Product attribute</param>
        void DeleteProductAttribute(ProductAttribute productAttribute);

        /// <summary>
        /// Gets all product attributes
        /// </summary>
        /// <returns>Product attribute collection</returns>
        IList<ProductAttribute> GetAllProductAttributes();

        /// <summary>
        /// Gets a product attribute 
        /// </summary>
        /// <param name="productAttributeId">Product attribute identifier</param>
        /// <returns>Product attribute </returns>
        ProductAttribute GetProductAttributeById(int productAttributeId);

        /// <summary>
        /// Inserts a product attribute
        /// </summary>
        /// <param name="productAttribute">Product attribute</param>
        void InsertProductAttribute(ProductAttribute productAttribute);

        /// <summary>
        /// Updates the product attribute
        /// </summary>
        /// <param name="productAttribute">Product attribute</param>
        void UpdateProductAttribute(ProductAttribute productAttribute);

        #endregion

        #region Product variant attributes mappings (ProductVariantAttribute)

        /// <summary>
        /// Deletes a product variant attribute mapping
        /// </summary>
        /// <param name="productVariantAttribute">Product variant attribute mapping</param>
        void DeleteProductVariantAttribute(ProductVariantAttribute productVariantAttribute);

        /// <summary>
        /// Gets product variant attribute mappings by product identifier
        /// </summary>
		/// <param name="productId">The product identifier</param>
        /// <returns>Product variant attribute mapping collection</returns>
		IList<ProductVariantAttribute> GetProductVariantAttributesByProductId(int productId);

		/// <summary>
		/// Gets product variant attribute mappings by multiple product identifiers
		/// </summary>
		/// <param name="productIds">The product identifiers</param>
		/// <param name="controlType">An optional control type filter. <c>null</c> loads all controls regardless of type.</param>
		/// <returns>A map with product id as key and a collection of variant attributes as value.</returns>
		Multimap<int, ProductVariantAttribute> GetProductVariantAttributesByProductIds(int[] productIds, AttributeControlType? controlType);

        /// <summary>
        /// Gets a product variant attribute mapping
        /// </summary>
        /// <param name="productVariantAttributeId">Product variant attribute mapping identifier</param>
        /// <returns>Product variant attribute mapping</returns>
        ProductVariantAttribute GetProductVariantAttributeById(int productVariantAttributeId);

		/// <summary>
		/// Gets product variant attribute mappings
		/// </summary>
		/// <param name="productVariantAttributeIds">Enumerable of product variant attribute mapping identifiers</param>
		/// <param name="attributes">Collection of already loaded product attribute mappings to reduce database round trips</param>
		/// <returns></returns>
		IList<ProductVariantAttribute> GetProductVariantAttributesByIds(IEnumerable<int> productVariantAttributeIds, IEnumerable<ProductVariantAttribute> attributes = null);

        /// <summary>
        /// Inserts a product variant attribute mapping
        /// </summary>
        /// <param name="productVariantAttribute">The product variant attribute mapping</param>
        void InsertProductVariantAttribute(ProductVariantAttribute productVariantAttribute);

        /// <summary>
        /// Updates the product variant attribute mapping
        /// </summary>
        /// <param name="productVariantAttribute">The product variant attribute mapping</param>
        void UpdateProductVariantAttribute(ProductVariantAttribute productVariantAttribute);

        #endregion

        #region Product variant attribute values (ProductVariantAttributeValue)

        /// <summary>
        /// Deletes a product variant attribute value
        /// </summary>
        /// <param name="productVariantAttributeValue">Product variant attribute value</param>
        void DeleteProductVariantAttributeValue(ProductVariantAttributeValue productVariantAttributeValue);

        /// <summary>
        /// Gets product variant attribute values by product identifier
        /// </summary>
        /// <param name="productVariantAttributeId">The product variant attribute mapping identifier</param>
        /// <returns>Product variant attribute mapping collection</returns>
        IList<ProductVariantAttributeValue> GetProductVariantAttributeValues(int productVariantAttributeId);

        /// <summary>
        /// Gets a product variant attribute value
        /// </summary>
        /// <param name="productVariantAttributeValueId">Product variant attribute value identifier</param>
        /// <returns>Product variant attribute value</returns>
        ProductVariantAttributeValue GetProductVariantAttributeValueById(int productVariantAttributeValueId);

        /// <summary>
        /// Gets multiple product variant attribute value
        /// </summary>
        /// <param name="productVariantAttributeValueIds">Product variant attribute value identifiers</param>
        /// <returns>List of Product variant attribute values</returns>
        IEnumerable<ProductVariantAttributeValue> GetProductVariantAttributeValuesByIds(params int[] productVariantAttributeValueIds);

        /// <summary>
        /// Inserts a product variant attribute value
        /// </summary>
        /// <param name="productVariantAttributeValue">The product variant attribute value</param>
        void InsertProductVariantAttributeValue(ProductVariantAttributeValue productVariantAttributeValue);

        /// <summary>
        /// Updates the product variant attribute value
        /// </summary>
        /// <param name="productVariantAttributeValue">The product variant attribute value</param>
        void UpdateProductVariantAttributeValue(ProductVariantAttributeValue productVariantAttributeValue);

        #endregion

        #region Product variant attribute combinations (ProductVariantAttributeCombination)

        /// <summary>
        /// Deletes a product variant attribute combination
        /// </summary>
        /// <param name="combination">Product variant attribute combination</param>
        void DeleteProductVariantAttributeCombination(ProductVariantAttributeCombination combination);

		/// <summary>
		/// Gets all product variant attribute combinations
		/// </summary>
		/// <param name="productId">Product identifier</param>
		/// <param name="pageIndex">Page index</param>
		/// <param name="pageSize">Page size</param>
		/// <param name="untracked">Specifies whether loaded entities should be tracked by the state manager</param>
		/// <returns>Product variant attribute combination collection</returns>
		IPagedList<ProductVariantAttributeCombination> GetAllProductVariantAttributeCombinations(int productId, int pageIndex, int pageSize, bool untracked = true);

		/// <summary>
		/// Gets product variant attribute combinations by multiple product identifiers
		/// </summary>
		/// <param name="productIds">The product identifiers</param>
		/// <returns>A map with product id as key and a collection of product variant attribute combinations as value.</returns>
		Multimap<int, ProductVariantAttributeCombination> GetProductVariantAttributeCombinations(int[] productIds);

		/// <summary>
		/// Get the lowest price of all combinations for a product
		/// </summary>
		/// <param name="productId">Product identifier</param>
		/// <returns>Lowest price</returns>
		decimal? GetLowestCombinationPrice(int productId);

        /// <summary>
		/// Gets a product variant attribute combination by identifier
        /// </summary>
        /// <param name="productVariantAttributeCombinationId">Product variant attribute combination identifier</param>
        /// <returns>Product variant attribute combination</returns>
        ProductVariantAttributeCombination GetProductVariantAttributeCombinationById(int productVariantAttributeCombinationId);

		/// <summary>
		/// /// Gets a product variant attribute combination by SKU
		/// </summary>
		/// <param name="sku">SKU</param>
		/// <returns>Product variant attribute combination</returns>
		ProductVariantAttributeCombination GetProductVariantAttributeCombinationBySku(string sku);

        /// <summary>
        /// Inserts a product variant attribute combination
        /// </summary>
        /// <param name="combination">Product variant attribute combination</param>
        void InsertProductVariantAttributeCombination(ProductVariantAttributeCombination combination);

        /// <summary>
        /// Updates a product variant attribute combination
        /// </summary>
        /// <param name="combination">Product variant attribute combination</param>
        void UpdateProductVariantAttributeCombination(ProductVariantAttributeCombination combination);

		/// <summary>
		/// Creates all variant attributes combinations
		/// </summary>
		void CreateAllProductVariantAttributeCombinations(Product product);

        /// <summary>
        /// Gets a value indicating the existence of any attribute combination for a product
        /// </summary>
        bool VariantHasAttributeCombinations(int productId);

        #endregion

		#region Product bundle item attribute filter

		/// <summary>
		/// Inserts a product bundle item attribute filter
		/// </summary>
		/// <param name="attributeFilter">Product bundle item attribute filter</param>
		void InsertProductBundleItemAttributeFilter(ProductBundleItemAttributeFilter attributeFilter);

		/// <summary>
		/// Updates the product bundle item attribute filter
		/// </summary>
		/// <param name="attributeFilter">Product bundle item attribute filter</param>
		void UpdateProductBundleItemAttributeFilter(ProductBundleItemAttributeFilter attributeFilter);

		/// <summary>
		/// Deletes a product bundle item attribute filter
		/// </summary>
		/// <param name="attributeFilter">Product bundle item attribute filter</param>
		void DeleteProductBundleItemAttributeFilter(ProductBundleItemAttributeFilter attributeFilter);

		/// <summary>
		/// Deletes all attribute filters of a bundle item
		/// </summary>
		/// <param name="bundleItem">Bundle item</param>
		void DeleteProductBundleItemAttributeFilter(ProductBundleItem bundleItem);

		/// <summary>
		/// Deletes product bundle item attribute filters
		/// </summary>
		/// <param name="attributeId">Attribute identifier</param>
		/// <param name="attributeValueId">Attribute value identifier</param>
		void DeleteProductBundleItemAttributeFilter(int attributeId, int attributeValueId);

		/// <summary>
		/// Deletes product bundle item attribute filters
		/// </summary>
		/// <param name="attributeId">Attribute identifier</param>
		void DeleteProductBundleItemAttributeFilter(int attributeId);

		#endregion
    }

	public static class IProductAttributeServiceExtensions
	{
		/// <summary>
		/// Gets all product variant attribute combinations
		/// </summary>
		/// <param name="productId">Product identifier</param>
		/// <returns>Product variant attribute combination collection</returns>
		public static IList<ProductVariantAttributeCombination> GetAllProductVariantAttributeCombinations(this IProductAttributeService service, int productId)
		{
			return service.GetAllProductVariantAttributeCombinations(productId, 0, int.MaxValue, true);
		}
	}
}
