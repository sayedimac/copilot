const { app } = require('@azure/functions');

app.http('GetData', {
    methods: ['GET', 'POST'],
    authLevel: 'anonymous',
    handler: async (request, context) => {
        context.log(`Http function processed request for url "${request.url}"`);

        // Return sample data
        const data = {
            items: [
                { id: 1, name: "Item 1", description: "This is item 1", value: 10.99 },
                { id: 2, name: "Item 2", description: "This is item 2", value: 20.49 },
                { id: 3, name: "Item 3", description: "This is item 3", value: 15.75 },
                { id: 4, name: "Item 4", description: "This is item 4", value: 8.25 },
                { id: 5, name: "Item 5", description: "This is item 5", value: 30.00 }
            ],
            timestamp: new Date().toISOString(),
            count: 5
        };

        return { 
            jsonBody: data,
            headers: {
                'Content-Type': 'application/json'
            }
        };
    }
});
