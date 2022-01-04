describe('When visiting tag page', () => {
    it('Then verify Umbraco tag page is accessible', () => {
        cy.visit('https://adolfi.dev/tags/umbraco');  
    });

    it('Then verify Unit Testing tag page is accessible', () => {
        cy.visit('https://adolfi.dev/tags/unit%20testing');  
    });

    it('Then verify .NET tag page is accessible', () => {
        cy.visit('https://adolfi.dev/tags/-net');  
    });
})