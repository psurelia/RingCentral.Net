namespace RingCentral
{
    public class PagingInfo : Serializable
    {
        // The current page number. 1-indexed, so the first page is 1 by default. May be omitted if result is empty (because non-existent page was specified or perPage=0 was requested)
        public long? page;
        // Current page size, describes how many items are in each page. Maximum value is 1000. If perPage value in the request is greater than 1000, the maximum value (1000) is applied
        public long? perPage;
        // The zero-based number of the first element on the current page. Omitted if the page is omitted or result is empty
        public long? pageStart;
        // The zero-based index of the last element on the current page. Omitted if the page is omitted or result is empty
        public long? pageEnd;
        // The total number of pages in a dataset. May be omitted for some resources due to performance reasons
        public long? totalPages;
        // The total number of elements in a dataset. May be omitted for some resource due to performance reasons
        public long? totalElements;
    }
}